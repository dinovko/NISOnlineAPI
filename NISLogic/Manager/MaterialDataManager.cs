using NISLogic.BusinessObjects;
using NISLogic.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace NISLogic.Manager
{
    public class MaterialDataManager : ManagerBase
    {
        public long SaveMaterialData(InfoMaterialAdd material, string conn)
        {
            using (IDbConnection con = new SqlConnectionFactory(conn).Create())
            {
                material.ID = con.ExecInsert("[dbo].[InfoMaterialAdd]", new
                {
                    material.ClassID,
                    material.SubjectNameID,
                    material.UserID,
                    material.SectionNameID,
                    material.ThemeNameID
                });

                con.ExecInsert("[dbo].[InterdisciplinaryRelationship]", new
                {
                    InfoMaterialID = material.ID,
                    material.InterdisciplinaryRelationshipObj.ClassID,
                    material.InterdisciplinaryRelationshipObj.SubjectNameID,
                    material.InterdisciplinaryRelationshipObj.UserID,
                    material.InterdisciplinaryRelationshipObj.SectionNameID,
                    material.InterdisciplinaryRelationshipObj.ThemeNameID
                });

                con.ExecInsert("[dbo].[BaseTheme]", new
                {
                    InfoMaterialID = material.ID,
                    material.BaseThemeObj.ClassID,
                    material.BaseThemeObj.UserID,
                    material.BaseThemeObj.SectionNameID,
                    material.BaseThemeObj.ThemeNameID
                });

                material.MaterialDataObj.ID = con.ExecInsert("[dbo].[MaterialData]", new
                {
                    InfoMaterialID = material.ID,
                    material.MaterialDataObj.MaterialNameRU,
                    material.MaterialDataObj.MaterialNameKZ,
                    material.MaterialDataObj.MaterialNameEN,
                });

                foreach (var item in material.MaterialDataObj.MaterialDataGlossaryList)
                {
                    con.ExecInsert("[dbo].[MaterialDataGlossary]", new
                    {
                        MaterialDataID = material.MaterialDataObj.ID,
                        item.GlossaryID
                    });
                }

                //foreach (var item in material.MaterialDataObj.MaterialDataImageList)
                //{
                //    con.ExecInsert("[dbo].[MaterialDataImage]", new
                //    {
                //        MaterialDataID = material.MaterialDataObj.ID
                //    });
                //}

                //foreach (var item in material.MaterialDataObj.MaterialDataVideoList)
                //{
                //    con.ExecInsert("[dbo].[MaterialDataVideo]", new
                //    {
                //        MaterialDataID = material.MaterialDataObj.ID
                //    });
                //}

                foreach (var item in material.MaterialDigEduResourcesList)
                {
                    con.ExecInsert("[dbo].[MaterialDigEduResources]", new
                    {
                        InfoMaterialID = material.ID,
                        item.NameRU,
                        item.NameKZ,
                        item.NameEN,
                        item.Link
                    });
                }

                foreach (var item in material.MaterialInteractiveList)
                {
                    con.ExecInsert("[dbo].[MaterialInteractive]", new
                    {
                        InfoMaterialID = material.ID,
                        item.NameRU,
                        item.NameKZ,
                        item.NameEN,
                        item.Link
                    });
                }

                material.MaterialAdditionalInformationObj.ID = con.ExecInsert("[dbo].[MaterialAdditionalInformation]", new
                {
                    InfoMaterialID = material.ID,
                    material.MaterialAdditionalInformationObj.MaterialNameRU,
                    material.MaterialAdditionalInformationObj.MaterialNameKZ,
                    material.MaterialAdditionalInformationObj.MaterialNameEN,
                    material.MaterialAdditionalInformationObj.Link
                });

                //foreach (var item in material.MaterialAdditionalInformationObj.MaterialAddInfoImageList)
                //{
                //    con.ExecInsert("[dbo].[MaterialAddInfoImage]", new
                //    {
                //        MaterialAddInfoID = material.MaterialAdditionalInformationObj.ID
                //    });
                //}

                //foreach (var item in material.MaterialAdditionalInformationObj.MaterialAddInfoVideoList)
                //{
                //    con.ExecInsert("[dbo].[MaterialAddInfoVideo]", new
                //    {
                //        MaterialAddInfoID = material.MaterialAdditionalInformationObj.ID
                //    });
                //}

                return material.ID;
            }
        }
    }
}

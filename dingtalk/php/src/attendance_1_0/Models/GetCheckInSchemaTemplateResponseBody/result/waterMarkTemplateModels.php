<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetCheckInSchemaTemplateResponseBody\result;

use AlibabaCloud\Tea\Model;

class waterMarkTemplateModels extends Model
{
    /**
     * @var bool
     */
    public $canModify;

    /**
     * @example PROC-292988B1-5064-4A42-9389-xxxxx
     *
     * @var string
     */
    public $formCode;

    /**
     * @example https://xx.xx.png
     *
     * @var string
     */
    public $icon;

    /**
     * @example {     \"widgetName\":\"dd_watermark_xxx_xxx\",     \"miniAppId\":\"50000xxx\",     \"templateRule\":{         \"maxItems\":6,         \"canEditColor\":true,         \"canEditTitle\":true,         \"items\":[          ]     },     \"layoutDesignId\":\"industry_xx_xx\",     \"width\":\"111\" }
     *
     * @var string
     */
    public $layoutDesign;

    /**
     * @example water_mark_checkin_open
     *
     * @var string
     */
    public $sceneCode;

    /**
     * @example {     \"items\":[         {             \"componentName\":\"HiddenField\",             \"props\":{                 \"bizAlias\":\"enableModifyPlace\",                 \"id\":\"enableModifyPlace-undefined\",                 \"value\":\"true\"             }         },         {             \"componentName\":\"HiddenField\",             \"props\":{                 \"bizAlias\":\"modifyPlaceDistance\",                 \"id\":\"modifyPlaceDistance-undefined\",                 \"value\":200             }         },         {             \"componentName\":\"HiddenField\",             \"props\":{                 \"bizAlias\":\"title\",                 \"id\":\"title-undefined\",                 \"value\":\"wofu1\"             }         },         {             \"componentName\":\"HiddenField\",             \"props\":{                 \"bizAlias\":\"titleBgColor\",                 \"id\":\"titleBgColor-undefined\",                 \"value\":\"#0089FF\"             }         }     ] }
     *
     * @var string
     */
    public $schemaContent;

    /**
     * @example suiteKey
     *
     * @var string
     */
    public $suiteKey;

    /**
     * @var bool
     */
    public $systemTemplate;

    /**
     * @example 标题
     *
     * @var string
     */
    public $title;

    /**
     * @example PROC-292988B1-5064-4A42-9389-xxxxx
     *
     * @var string
     */
    public $waterMarkId;
    protected $_name = [
        'canModify' => 'canModify',
        'formCode' => 'formCode',
        'icon' => 'icon',
        'layoutDesign' => 'layoutDesign',
        'sceneCode' => 'sceneCode',
        'schemaContent' => 'schemaContent',
        'suiteKey' => 'suiteKey',
        'systemTemplate' => 'systemTemplate',
        'title' => 'title',
        'waterMarkId' => 'waterMarkId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->canModify) {
            $res['canModify'] = $this->canModify;
        }
        if (null !== $this->formCode) {
            $res['formCode'] = $this->formCode;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->layoutDesign) {
            $res['layoutDesign'] = $this->layoutDesign;
        }
        if (null !== $this->sceneCode) {
            $res['sceneCode'] = $this->sceneCode;
        }
        if (null !== $this->schemaContent) {
            $res['schemaContent'] = $this->schemaContent;
        }
        if (null !== $this->suiteKey) {
            $res['suiteKey'] = $this->suiteKey;
        }
        if (null !== $this->systemTemplate) {
            $res['systemTemplate'] = $this->systemTemplate;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->waterMarkId) {
            $res['waterMarkId'] = $this->waterMarkId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return waterMarkTemplateModels
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['canModify'])) {
            $model->canModify = $map['canModify'];
        }
        if (isset($map['formCode'])) {
            $model->formCode = $map['formCode'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['layoutDesign'])) {
            $model->layoutDesign = $map['layoutDesign'];
        }
        if (isset($map['sceneCode'])) {
            $model->sceneCode = $map['sceneCode'];
        }
        if (isset($map['schemaContent'])) {
            $model->schemaContent = $map['schemaContent'];
        }
        if (isset($map['suiteKey'])) {
            $model->suiteKey = $map['suiteKey'];
        }
        if (isset($map['systemTemplate'])) {
            $model->systemTemplate = $map['systemTemplate'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['waterMarkId'])) {
            $model->waterMarkId = $map['waterMarkId'];
        }

        return $model;
    }
}

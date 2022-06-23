<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetCheckInSchemaTemplateResponseBody\result;

use AlibabaCloud\Tea\Model;

class waterMarkTemplateModels extends Model
{
    /**
     * @description 是否可以修改。
     *
     * @var bool
     */
    public $canModify;

    /**
     * @description 模板的表单Code。
     *
     * @var string
     */
    public $formCode;

    /**
     * @description 模板的预览图片。
     *
     * @var string
     */
    public $icon;

    /**
     * @description 模板的布局信息。
     *
     * @var string
     */
    public $layoutDesign;

    /**
     * @description 模板的场景码。
     *
     * @var string
     */
    public $sceneCode;

    /**
     * @description 模板的内容。
     *
     * @var string
     */
    public $schemaContent;

    /**
     * @description suiteKey。
     *
     * @var string
     */
    public $suiteKey;

    /**
     * @description 是否系统模板。
     *
     * @var bool
     */
    public $systemTemplate;

    /**
     * @description 模板的标题。
     *
     * @var string
     */
    public $title;

    /**
     * @description 模板的水印ID。
     *
     * @var string
     */
    public $waterMarkId;
    protected $_name = [
        'canModify'      => 'canModify',
        'formCode'       => 'formCode',
        'icon'           => 'icon',
        'layoutDesign'   => 'layoutDesign',
        'sceneCode'      => 'sceneCode',
        'schemaContent'  => 'schemaContent',
        'suiteKey'       => 'suiteKey',
        'systemTemplate' => 'systemTemplate',
        'title'          => 'title',
        'waterMarkId'    => 'waterMarkId',
    ];

    public function validate()
    {
    }

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

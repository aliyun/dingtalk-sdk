<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class SavePrintTplDetailInfoRequest extends Model
{
    /**
     * @description 表单id
     *
     * @var string
     */
    public $formUuid;

    /**
     * @description 应用代码
     *
     * @var string
     */
    public $appType;

    /**
     * @description 模板的VM
     *
     * @var string
     */
    public $vm;

    /**
     * @description 表单版本
     *
     * @var int
     */
    public $formVersion;

    /**
     * @description 打印模板id
     *
     * @var int
     */
    public $templateId;

    /**
     * @description 用户id
     *
     * @var string
     */
    public $userId;

    /**
     * @description 模板的其他配置信息
     *
     * @var string
     */
    public $setting;

    /**
     * @description 模板标题
     *
     * @var string
     */
    public $title;

    /**
     * @description 模板描述
     *
     * @var string
     */
    public $description;

    /**
     * @description 文件名配置
     *
     * @var string
     */
    public $fileNameConfig;
    protected $_name = [
        'formUuid'       => 'formUuid',
        'appType'        => 'appType',
        'vm'             => 'vm',
        'formVersion'    => 'formVersion',
        'templateId'     => 'templateId',
        'userId'         => 'userId',
        'setting'        => 'setting',
        'title'          => 'title',
        'description'    => 'description',
        'fileNameConfig' => 'fileNameConfig',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
        }
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->vm) {
            $res['vm'] = $this->vm;
        }
        if (null !== $this->formVersion) {
            $res['formVersion'] = $this->formVersion;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->setting) {
            $res['setting'] = $this->setting;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->fileNameConfig) {
            $res['fileNameConfig'] = $this->fileNameConfig;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SavePrintTplDetailInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['vm'])) {
            $model->vm = $map['vm'];
        }
        if (isset($map['formVersion'])) {
            $model->formVersion = $map['formVersion'];
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['setting'])) {
            $model->setting = $map['setting'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['fileNameConfig'])) {
            $model->fileNameConfig = $map['fileNameConfig'];
        }

        return $model;
    }
}

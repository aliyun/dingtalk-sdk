<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vats_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateApplicationRegFormResponseBody extends Model
{
    /**
     * @description 创建时间（邀填时间，单位：毫秒）
     *
     * @var int
     */
    public $gmtCreateMillis;

    /**
     * @description 更新时间（填写时间，单位：毫秒），仅当表单状态为已填写时有效
     *
     * @var int
     */
    public $gmtModifiedMillis;

    /**
     * @description 模板标识
     *
     * @var string
     */
    public $templateId;

    /**
     * @description 模板版本
     *
     * @var int
     */
    public $templateVersion;

    /**
     * @description 表单标识
     *
     * @var string
     */
    public $formId;

    /**
     * @description 表单状态（0表示未填写，1表示已填写）
     *
     * @var int
     */
    public $status;

    /**
     * @description 邀填人员工标识
     *
     * @var string
     */
    public $creatorUserId;
    protected $_name = [
        'gmtCreateMillis'   => 'gmtCreateMillis',
        'gmtModifiedMillis' => 'gmtModifiedMillis',
        'templateId'        => 'templateId',
        'templateVersion'   => 'templateVersion',
        'formId'            => 'formId',
        'status'            => 'status',
        'creatorUserId'     => 'creatorUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->gmtCreateMillis) {
            $res['gmtCreateMillis'] = $this->gmtCreateMillis;
        }
        if (null !== $this->gmtModifiedMillis) {
            $res['gmtModifiedMillis'] = $this->gmtModifiedMillis;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }
        if (null !== $this->templateVersion) {
            $res['templateVersion'] = $this->templateVersion;
        }
        if (null !== $this->formId) {
            $res['formId'] = $this->formId;
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->creatorUserId) {
            $res['creatorUserId'] = $this->creatorUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateApplicationRegFormResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['gmtCreateMillis'])) {
            $model->gmtCreateMillis = $map['gmtCreateMillis'];
        }
        if (isset($map['gmtModifiedMillis'])) {
            $model->gmtModifiedMillis = $map['gmtModifiedMillis'];
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['templateVersion'])) {
            $model->templateVersion = $map['templateVersion'];
        }
        if (isset($map['formId'])) {
            $model->formId = $map['formId'];
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['creatorUserId'])) {
            $model->creatorUserId = $map['creatorUserId'];
        }

        return $model;
    }
}

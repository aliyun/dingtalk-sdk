<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\CreateRecordRequest;

use AlibabaCloud\Tea\Model;

class attachmentList extends Model
{
    /**
     * @example attachment_profile
     *
     * @var string
     */
    public $fieldCode;

    /**
     * @example 简历附件
     *
     * @var string
     */
    public $fieldName;

    /**
     * @example DDAttachmentField
     *
     * @var string
     */
    public $fieldType;

    /**
     * @example https://dt-staging-moka-public.oss-cn-zhangjiakou.aliyuncs.com/form/attachment/b32509e4a809cb4e18a72fc4aa75e655.pdf
     *
     * @var string
     */
    public $fieldValue;

    /**
     * @example attachment
     *
     * @var string
     */
    public $groupId;
    protected $_name = [
        'fieldCode'  => 'fieldCode',
        'fieldName'  => 'fieldName',
        'fieldType'  => 'fieldType',
        'fieldValue' => 'fieldValue',
        'groupId'    => 'groupId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->fieldCode) {
            $res['fieldCode'] = $this->fieldCode;
        }
        if (null !== $this->fieldName) {
            $res['fieldName'] = $this->fieldName;
        }
        if (null !== $this->fieldType) {
            $res['fieldType'] = $this->fieldType;
        }
        if (null !== $this->fieldValue) {
            $res['fieldValue'] = $this->fieldValue;
        }
        if (null !== $this->groupId) {
            $res['groupId'] = $this->groupId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return attachmentList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fieldCode'])) {
            $model->fieldCode = $map['fieldCode'];
        }
        if (isset($map['fieldName'])) {
            $model->fieldName = $map['fieldName'];
        }
        if (isset($map['fieldType'])) {
            $model->fieldType = $map['fieldType'];
        }
        if (isset($map['fieldValue'])) {
            $model->fieldValue = $map['fieldValue'];
        }
        if (isset($map['groupId'])) {
            $model->groupId = $map['groupId'];
        }

        return $model;
    }
}

<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\GetFileTemplateListResponseBody\result\data;

use AlibabaCloud\Tea\Model;

class attachmentList extends Model
{
    /**
     * @example 简历附件
     *
     * @var string
     */
    public $desc;

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
     * @example attachment
     *
     * @var string
     */
    public $groupId;

    /**
     * @var bool
     */
    public $signRequired;

    /**
     * @var bool
     */
    public $userCustomField;
    protected $_name = [
        'desc'            => 'desc',
        'fieldCode'       => 'fieldCode',
        'fieldName'       => 'fieldName',
        'fieldType'       => 'fieldType',
        'groupId'         => 'groupId',
        'signRequired'    => 'signRequired',
        'userCustomField' => 'userCustomField',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->desc) {
            $res['desc'] = $this->desc;
        }
        if (null !== $this->fieldCode) {
            $res['fieldCode'] = $this->fieldCode;
        }
        if (null !== $this->fieldName) {
            $res['fieldName'] = $this->fieldName;
        }
        if (null !== $this->fieldType) {
            $res['fieldType'] = $this->fieldType;
        }
        if (null !== $this->groupId) {
            $res['groupId'] = $this->groupId;
        }
        if (null !== $this->signRequired) {
            $res['signRequired'] = $this->signRequired;
        }
        if (null !== $this->userCustomField) {
            $res['userCustomField'] = $this->userCustomField;
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
        if (isset($map['desc'])) {
            $model->desc = $map['desc'];
        }
        if (isset($map['fieldCode'])) {
            $model->fieldCode = $map['fieldCode'];
        }
        if (isset($map['fieldName'])) {
            $model->fieldName = $map['fieldName'];
        }
        if (isset($map['fieldType'])) {
            $model->fieldType = $map['fieldType'];
        }
        if (isset($map['groupId'])) {
            $model->groupId = $map['groupId'];
        }
        if (isset($map['signRequired'])) {
            $model->signRequired = $map['signRequired'];
        }
        if (isset($map['userCustomField'])) {
            $model->userCustomField = $map['userCustomField'];
        }

        return $model;
    }
}

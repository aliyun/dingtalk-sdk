<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\GetFileTemplateListResponseBody\result\data\groupList;

use AlibabaCloud\Tea\Model;

class fieldList extends Model
{
    /**
     * @example 家庭成员明细分组
     *
     * @var string
     */
    public $desc;

    /**
     * @example family.member_name
     *
     * @var string
     */
    public $fieldCode;

    /**
     * @example 成员姓名
     *
     * @var string
     */
    public $fieldName;

    /**
     * @example TextField
     *
     * @var string
     */
    public $fieldType;

    /**
     * @example family
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
        'desc' => 'desc',
        'fieldCode' => 'fieldCode',
        'fieldName' => 'fieldName',
        'fieldType' => 'fieldType',
        'groupId' => 'groupId',
        'signRequired' => 'signRequired',
        'userCustomField' => 'userCustomField',
    ];

    public function validate() {}

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
     * @return fieldList
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

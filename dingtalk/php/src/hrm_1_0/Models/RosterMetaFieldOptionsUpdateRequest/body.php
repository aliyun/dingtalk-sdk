<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\RosterMetaFieldOptionsUpdateRequest;

use AlibabaCloud\Tea\Model;

class body extends Model
{
    /**
     * @description 字段fieldCode
     *
     * @var string
     */
    public $fieldCode;

    /**
     * @description 花名册分组id
     *
     * @var string
     */
    public $groupId;

    /**
     * @description 需要修改的选项值
     *
     * @var string[]
     */
    public $labels;

    /**
     * @description 修改类型，OPTIONS_ADD选项添加，OPTIONS_DELETE选项删除
     *
     * @var string
     */
    public $modifyType;
    protected $_name = [
        'fieldCode'  => 'fieldCode',
        'groupId'    => 'groupId',
        'labels'     => 'labels',
        'modifyType' => 'modifyType',
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
        if (null !== $this->groupId) {
            $res['groupId'] = $this->groupId;
        }
        if (null !== $this->labels) {
            $res['labels'] = $this->labels;
        }
        if (null !== $this->modifyType) {
            $res['modifyType'] = $this->modifyType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return body
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['fieldCode'])) {
            $model->fieldCode = $map['fieldCode'];
        }
        if (isset($map['groupId'])) {
            $model->groupId = $map['groupId'];
        }
        if (isset($map['labels'])) {
            if (!empty($map['labels'])) {
                $model->labels = $map['labels'];
            }
        }
        if (isset($map['modifyType'])) {
            $model->modifyType = $map['modifyType'];
        }

        return $model;
    }
}

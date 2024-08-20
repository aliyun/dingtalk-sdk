<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\CreateRecordRequest;

use AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\undefined;
use AlibabaCloud\Tea\Model;

class groupList extends Model
{
    /**
     * @var bool
     */
    public $detailFlag;

    /**
     * @var undefined[][]
     */
    public $fieldList;

    /**
     * @example family
     *
     * @var string
     */
    public $groupId;

    /**
     * @example 家庭成员
     *
     * @var string
     */
    public $groupName;
    protected $_name = [
        'detailFlag' => 'detailFlag',
        'fieldList'  => 'fieldList',
        'groupId'    => 'groupId',
        'groupName'  => 'groupName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->detailFlag) {
            $res['detailFlag'] = $this->detailFlag;
        }
        if (null !== $this->fieldList) {
            $res['fieldList'] = $this->fieldList;
        }
        if (null !== $this->groupId) {
            $res['groupId'] = $this->groupId;
        }
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return groupList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['detailFlag'])) {
            $model->detailFlag = $map['detailFlag'];
        }
        if (isset($map['fieldList'])) {
            if (!empty($map['fieldList'])) {
                $model->fieldList = $map['fieldList'];
            }
        }
        if (isset($map['groupId'])) {
            $model->groupId = $map['groupId'];
        }
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }

        return $model;
    }
}

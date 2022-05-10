<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class DigitalStoreGroupInfoResponseBody extends Model
{
    /**
     * @description 分组Id
     *
     * @var int
     */
    public $groupId;

    /**
     * @description 分组名称
     *
     * @var string
     */
    public $groupName;

    /**
     * @description 分组中门店Id列表
     *
     * @var int[]
     */
    public $storeIdList;
    protected $_name = [
        'groupId'     => 'groupId',
        'groupName'   => 'groupName',
        'storeIdList' => 'storeIdList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->groupId) {
            $res['groupId'] = $this->groupId;
        }
        if (null !== $this->groupName) {
            $res['groupName'] = $this->groupName;
        }
        if (null !== $this->storeIdList) {
            $res['storeIdList'] = $this->storeIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DigitalStoreGroupInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['groupId'])) {
            $model->groupId = $map['groupId'];
        }
        if (isset($map['groupName'])) {
            $model->groupName = $map['groupName'];
        }
        if (isset($map['storeIdList'])) {
            if (!empty($map['storeIdList'])) {
                $model->storeIdList = $map['storeIdList'];
            }
        }

        return $model;
    }
}

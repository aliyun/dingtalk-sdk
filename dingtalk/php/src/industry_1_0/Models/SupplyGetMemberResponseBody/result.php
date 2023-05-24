<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyGetMemberResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\SupplyGetMemberResponseBody\result\roleInfoList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var int[]
     */
    public $deptIdList;

    /**
     * @example NORMAL
     *
     * @var string
     */
    public $dingMemberStatus;

    /**
     * @example true
     *
     * @var bool
     */
    public $isActive;

    /**
     * @example 李白
     *
     * @var string
     */
    public $memberName;

    /**
     * @example 经理
     *
     * @var string
     */
    public $memberTitle;

    /**
     * @example 123
     *
     * @var string
     */
    public $memberWorkNumber;

    /**
     * @var roleInfoList[]
     */
    public $roleInfoList;

    /**
     * @var int[]
     */
    public $supplyNodeList;
    protected $_name = [
        'deptIdList'       => 'deptIdList',
        'dingMemberStatus' => 'dingMemberStatus',
        'isActive'         => 'isActive',
        'memberName'       => 'memberName',
        'memberTitle'      => 'memberTitle',
        'memberWorkNumber' => 'memberWorkNumber',
        'roleInfoList'     => 'roleInfoList',
        'supplyNodeList'   => 'supplyNodeList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptIdList) {
            $res['deptIdList'] = $this->deptIdList;
        }
        if (null !== $this->dingMemberStatus) {
            $res['dingMemberStatus'] = $this->dingMemberStatus;
        }
        if (null !== $this->isActive) {
            $res['isActive'] = $this->isActive;
        }
        if (null !== $this->memberName) {
            $res['memberName'] = $this->memberName;
        }
        if (null !== $this->memberTitle) {
            $res['memberTitle'] = $this->memberTitle;
        }
        if (null !== $this->memberWorkNumber) {
            $res['memberWorkNumber'] = $this->memberWorkNumber;
        }
        if (null !== $this->roleInfoList) {
            $res['roleInfoList'] = [];
            if (null !== $this->roleInfoList && \is_array($this->roleInfoList)) {
                $n = 0;
                foreach ($this->roleInfoList as $item) {
                    $res['roleInfoList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->supplyNodeList) {
            $res['supplyNodeList'] = $this->supplyNodeList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptIdList'])) {
            if (!empty($map['deptIdList'])) {
                $model->deptIdList = $map['deptIdList'];
            }
        }
        if (isset($map['dingMemberStatus'])) {
            $model->dingMemberStatus = $map['dingMemberStatus'];
        }
        if (isset($map['isActive'])) {
            $model->isActive = $map['isActive'];
        }
        if (isset($map['memberName'])) {
            $model->memberName = $map['memberName'];
        }
        if (isset($map['memberTitle'])) {
            $model->memberTitle = $map['memberTitle'];
        }
        if (isset($map['memberWorkNumber'])) {
            $model->memberWorkNumber = $map['memberWorkNumber'];
        }
        if (isset($map['roleInfoList'])) {
            if (!empty($map['roleInfoList'])) {
                $model->roleInfoList = [];
                $n                   = 0;
                foreach ($map['roleInfoList'] as $item) {
                    $model->roleInfoList[$n++] = null !== $item ? roleInfoList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['supplyNodeList'])) {
            if (!empty($map['supplyNodeList'])) {
                $model->supplyNodeList = $map['supplyNodeList'];
            }
        }

        return $model;
    }
}

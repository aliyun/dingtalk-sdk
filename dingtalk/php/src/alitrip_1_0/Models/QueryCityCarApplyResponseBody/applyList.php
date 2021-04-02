<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\QueryCityCarApplyResponseBody;

use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\QueryCityCarApplyResponseBody\applyList\approverList;
use AlibabaCloud\SDK\Dingtalk\Valitrip_1_0\Models\QueryCityCarApplyResponseBody\applyList\itineraryList;
use AlibabaCloud\Tea\Model;

class applyList extends Model
{
    /**
     * @description 审批单列表
     *
     * @var approverList[]
     */
    public $approverList;

    /**
     * @description 员工所在部门ID
     *
     * @var string
     */
    public $departId;

    /**
     * @description 员工所在部门名
     *
     * @var string
     */
    public $departName;

    /**
     * @description 创建时间
     *
     * @var string
     */
    public $gmtCreate;

    /**
     * @description 最近修改时间
     *
     * @var string
     */
    public $gmtModified;

    /**
     * @description 审批单关联的行程
     *
     * @var itineraryList[]
     */
    public $itineraryList;

    /**
     * @description 审批单状态：0-申请，1-同意，2-拒绝
     *
     * @var int
     */
    public $status;

    /**
     * @description 审批单状态：0-申请，1-同意，2-拒绝
     *
     * @var string
     */
    public $statusDesc;

    /**
     * @description 三方审批单ID
     *
     * @var string
     */
    public $thirdPartApplyId;

    /**
     * @description 申请事由
     *
     * @var string
     */
    public $tripCause;

    /**
     * @description 审批单标题
     *
     * @var string
     */
    public $tripTitle;

    /**
     * @description 发起审批员工ID
     *
     * @var string
     */
    public $userId;

    /**
     * @description 发起审批员工名
     *
     * @var string
     */
    public $userName;
    protected $_name = [
        'approverList'     => 'approverList',
        'departId'         => 'departId',
        'departName'       => 'departName',
        'gmtCreate'        => 'gmtCreate',
        'gmtModified'      => 'gmtModified',
        'itineraryList'    => 'itineraryList',
        'status'           => 'status',
        'statusDesc'       => 'statusDesc',
        'thirdPartApplyId' => 'thirdPartApplyId',
        'tripCause'        => 'tripCause',
        'tripTitle'        => 'tripTitle',
        'userId'           => 'userId',
        'userName'         => 'userName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->approverList) {
            $res['approverList'] = [];
            if (null !== $this->approverList && \is_array($this->approverList)) {
                $n = 0;
                foreach ($this->approverList as $item) {
                    $res['approverList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->departId) {
            $res['departId'] = $this->departId;
        }
        if (null !== $this->departName) {
            $res['departName'] = $this->departName;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->itineraryList) {
            $res['itineraryList'] = [];
            if (null !== $this->itineraryList && \is_array($this->itineraryList)) {
                $n = 0;
                foreach ($this->itineraryList as $item) {
                    $res['itineraryList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->status) {
            $res['status'] = $this->status;
        }
        if (null !== $this->statusDesc) {
            $res['statusDesc'] = $this->statusDesc;
        }
        if (null !== $this->thirdPartApplyId) {
            $res['thirdPartApplyId'] = $this->thirdPartApplyId;
        }
        if (null !== $this->tripCause) {
            $res['tripCause'] = $this->tripCause;
        }
        if (null !== $this->tripTitle) {
            $res['tripTitle'] = $this->tripTitle;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->userName) {
            $res['userName'] = $this->userName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return applyList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['approverList'])) {
            if (!empty($map['approverList'])) {
                $model->approverList = [];
                $n                   = 0;
                foreach ($map['approverList'] as $item) {
                    $model->approverList[$n++] = null !== $item ? approverList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['departId'])) {
            $model->departId = $map['departId'];
        }
        if (isset($map['departName'])) {
            $model->departName = $map['departName'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['itineraryList'])) {
            if (!empty($map['itineraryList'])) {
                $model->itineraryList = [];
                $n                    = 0;
                foreach ($map['itineraryList'] as $item) {
                    $model->itineraryList[$n++] = null !== $item ? itineraryList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['status'])) {
            $model->status = $map['status'];
        }
        if (isset($map['statusDesc'])) {
            $model->statusDesc = $map['statusDesc'];
        }
        if (isset($map['thirdPartApplyId'])) {
            $model->thirdPartApplyId = $map['thirdPartApplyId'];
        }
        if (isset($map['tripCause'])) {
            $model->tripCause = $map['tripCause'];
        }
        if (isset($map['tripTitle'])) {
            $model->tripTitle = $map['tripTitle'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['userName'])) {
            $model->userName = $map['userName'];
        }

        return $model;
    }
}

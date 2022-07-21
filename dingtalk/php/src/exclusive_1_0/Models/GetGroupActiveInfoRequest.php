<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetGroupActiveInfoRequest extends Model
{
    /**
     * @description 钉钉群组id
     *
     * @var string
     */
    public $dingGroupId;

    /**
     * @description 群类型：1-全员群，2-部门群，3-（其他）内部群，4-场景群
     *
     * @var int
     */
    public $groupType;

    /**
     * @description 分页起始页
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 分页大小
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description 统计日期
     *
     * @var string
     */
    public $statDate;
    protected $_name = [
        'dingGroupId' => 'dingGroupId',
        'groupType'   => 'groupType',
        'pageNumber'  => 'pageNumber',
        'pageSize'    => 'pageSize',
        'statDate'    => 'statDate',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingGroupId) {
            $res['dingGroupId'] = $this->dingGroupId;
        }
        if (null !== $this->groupType) {
            $res['groupType'] = $this->groupType;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->statDate) {
            $res['statDate'] = $this->statDate;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetGroupActiveInfoRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingGroupId'])) {
            $model->dingGroupId = $map['dingGroupId'];
        }
        if (isset($map['groupType'])) {
            $model->groupType = $map['groupType'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['statDate'])) {
            $model->statDate = $map['statDate'];
        }

        return $model;
    }
}

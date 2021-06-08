<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetGroupActiveInfoRequest extends Model
{
    /**
     * @description 统计日期
     *
     * @var string
     */
    public $statDate;

    /**
     * @description 钉钉群组id
     *
     * @var string
     */
    public $dingGroupId;

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
    protected $_name = [
        'statDate'    => 'statDate',
        'dingGroupId' => 'dingGroupId',
        'pageNumber'  => 'pageNumber',
        'pageSize'    => 'pageSize',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->statDate) {
            $res['statDate'] = $this->statDate;
        }
        if (null !== $this->dingGroupId) {
            $res['dingGroupId'] = $this->dingGroupId;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
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
        if (isset($map['statDate'])) {
            $model->statDate = $map['statDate'];
        }
        if (isset($map['dingGroupId'])) {
            $model->dingGroupId = $map['dingGroupId'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }

        return $model;
    }
}

<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetGroupActiveInfoRequest extends Model
{
    /**
     * @example cidV3xxxrSuxxxxxxnB8o8gJw==
     *
     * @var string
     */
    public $dingGroupId;

    /**
     * @example 1
     *
     * @var int
     */
    public $groupType;

    /**
     * @example 0
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @example 10
     *
     * @var int
     */
    public $pageSize;

    /**
     * @example 20200305
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

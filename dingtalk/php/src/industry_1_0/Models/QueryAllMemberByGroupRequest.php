<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryAllMemberByGroupRequest extends Model
{
    /**
     * @description 按月查询标识
     *
     * @var string
     */
    public $monthMark;

    /**
     * @description 分页查询页码
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 分页查询分页大小
     *
     * @var int
     */
    public $pageSize;
    protected $_name = [
        'monthMark'  => 'monthMark',
        'pageNumber' => 'pageNumber',
        'pageSize'   => 'pageSize',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->monthMark) {
            $res['monthMark'] = $this->monthMark;
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
     * @return QueryAllMemberByGroupRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['monthMark'])) {
            $model->monthMark = $map['monthMark'];
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

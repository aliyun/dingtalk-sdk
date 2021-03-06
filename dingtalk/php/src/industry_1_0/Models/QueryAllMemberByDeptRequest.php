<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryAllMemberByDeptRequest extends Model
{
    /**
     * @description 分页查询页容量
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description 分页查询页码
     *
     * @var int
     */
    public $pageNumber;
    protected $_name = [
        'pageSize'   => 'pageSize',
        'pageNumber' => 'pageNumber',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryAllMemberByDeptRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }

        return $model;
    }
}

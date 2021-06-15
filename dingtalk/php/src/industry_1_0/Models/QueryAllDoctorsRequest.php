<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryAllDoctorsRequest extends Model
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
    public $pageNum;
    protected $_name = [
        'pageSize' => 'pageSize',
        'pageNum'  => 'pageNum',
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
        if (null !== $this->pageNum) {
            $res['pageNum'] = $this->pageNum;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryAllDoctorsRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['pageNum'])) {
            $model->pageNum = $map['pageNum'];
        }

        return $model;
    }
}

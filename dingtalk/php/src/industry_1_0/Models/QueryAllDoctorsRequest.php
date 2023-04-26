<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryAllDoctorsRequest extends Model
{
    /**
     * @var string
     */
    public $monthMark;

    /**
     * @example 1
     *
     * @var int
     */
    public $pageNum;

    /**
     * @example 200
     *
     * @var int
     */
    public $pageSize;
    protected $_name = [
        'monthMark' => 'monthMark',
        'pageNum'   => 'pageNum',
        'pageSize'  => 'pageSize',
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
        if (null !== $this->pageNum) {
            $res['pageNum'] = $this->pageNum;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
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
        if (isset($map['monthMark'])) {
            $model->monthMark = $map['monthMark'];
        }
        if (isset($map['pageNum'])) {
            $model->pageNum = $map['pageNum'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }

        return $model;
    }
}

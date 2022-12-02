<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryDoctorDetailsByJobNumberRequest extends Model
{
    /**
     * @description 按月安排
     *
     * @var string
     */
    public $monthMark;
    protected $_name = [
        'monthMark' => 'monthMark',
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

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryDoctorDetailsByJobNumberRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['monthMark'])) {
            $model->monthMark = $map['monthMark'];
        }

        return $model;
    }
}

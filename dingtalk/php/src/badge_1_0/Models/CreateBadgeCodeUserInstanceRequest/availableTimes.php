<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models\CreateBadgeCodeUserInstanceRequest;

use AlibabaCloud\Tea\Model;

class availableTimes extends Model
{
    /**
     * @description 开始时间
     *
     * @var string
     */
    public $gmtStart;

    /**
     * @description 结束时间
     *
     * @var string
     */
    public $gmtEnd;
    protected $_name = [
        'gmtStart' => 'gmtStart',
        'gmtEnd'   => 'gmtEnd',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->gmtStart) {
            $res['gmtStart'] = $this->gmtStart;
        }
        if (null !== $this->gmtEnd) {
            $res['gmtEnd'] = $this->gmtEnd;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return availableTimes
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['gmtStart'])) {
            $model->gmtStart = $map['gmtStart'];
        }
        if (isset($map['gmtEnd'])) {
            $model->gmtEnd = $map['gmtEnd'];
        }

        return $model;
    }
}

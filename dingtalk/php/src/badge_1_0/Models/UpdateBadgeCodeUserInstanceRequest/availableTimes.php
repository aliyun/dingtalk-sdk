<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vbadge_1_0\Models\UpdateBadgeCodeUserInstanceRequest;

use AlibabaCloud\Tea\Model;

class availableTimes extends Model
{
    /**
     * @description 结束时间
     *
     * @var string
     */
    public $gmtEnd;

    /**
     * @description 开始时间
     *
     * @var string
     */
    public $gmtStart;
    protected $_name = [
        'gmtEnd'   => 'gmtEnd',
        'gmtStart' => 'gmtStart',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->gmtEnd) {
            $res['gmtEnd'] = $this->gmtEnd;
        }
        if (null !== $this->gmtStart) {
            $res['gmtStart'] = $this->gmtStart;
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
        if (isset($map['gmtEnd'])) {
            $model->gmtEnd = $map['gmtEnd'];
        }
        if (isset($map['gmtStart'])) {
            $model->gmtStart = $map['gmtStart'];
        }

        return $model;
    }
}

<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\BatchGetTaskResultResponseBody\tasks\result\items;

use AlibabaCloud\Tea\Model;

class subs extends Model
{
    /**
     * @var int
     */
    public $point;

    /**
     * @var string
     */
    public $reference;

    /**
     * @var string[]
     */
    public $referenceFrame;

    /**
     * @var string
     */
    public $subInfo;

    /**
     * @var string
     */
    public $subName;
    protected $_name = [
        'point'          => 'point',
        'reference'      => 'reference',
        'referenceFrame' => 'referenceFrame',
        'subInfo'        => 'subInfo',
        'subName'        => 'subName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->point) {
            $res['point'] = $this->point;
        }
        if (null !== $this->reference) {
            $res['reference'] = $this->reference;
        }
        if (null !== $this->referenceFrame) {
            $res['referenceFrame'] = $this->referenceFrame;
        }
        if (null !== $this->subInfo) {
            $res['subInfo'] = $this->subInfo;
        }
        if (null !== $this->subName) {
            $res['subName'] = $this->subName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return subs
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['point'])) {
            $model->point = $map['point'];
        }
        if (isset($map['reference'])) {
            $model->reference = $map['reference'];
        }
        if (isset($map['referenceFrame'])) {
            if (!empty($map['referenceFrame'])) {
                $model->referenceFrame = $map['referenceFrame'];
            }
        }
        if (isset($map['subInfo'])) {
            $model->subInfo = $map['subInfo'];
        }
        if (isset($map['subName'])) {
            $model->subName = $map['subName'];
        }

        return $model;
    }
}

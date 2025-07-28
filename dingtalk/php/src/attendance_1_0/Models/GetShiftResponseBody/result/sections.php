<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetShiftResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetShiftResponseBody\result\sections\punches;
use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetShiftResponseBody\result\sections\rests;
use AlibabaCloud\Tea\Model;

class sections extends Model
{
    /**
     * @var punches[]
     */
    public $punches;

    /**
     * @var rests[]
     */
    public $rests;

    /**
     * @var int
     */
    public $sectionId;
    protected $_name = [
        'punches' => 'punches',
        'rests' => 'rests',
        'sectionId' => 'sectionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->punches) {
            $res['punches'] = [];
            if (null !== $this->punches && \is_array($this->punches)) {
                $n = 0;
                foreach ($this->punches as $item) {
                    $res['punches'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->rests) {
            $res['rests'] = [];
            if (null !== $this->rests && \is_array($this->rests)) {
                $n = 0;
                foreach ($this->rests as $item) {
                    $res['rests'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->sectionId) {
            $res['sectionId'] = $this->sectionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return sections
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['punches'])) {
            if (!empty($map['punches'])) {
                $model->punches = [];
                $n = 0;
                foreach ($map['punches'] as $item) {
                    $model->punches[$n++] = null !== $item ? punches::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['rests'])) {
            if (!empty($map['rests'])) {
                $model->rests = [];
                $n = 0;
                foreach ($map['rests'] as $item) {
                    $model->rests[$n++] = null !== $item ? rests::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['sectionId'])) {
            $model->sectionId = $map['sectionId'];
        }

        return $model;
    }
}

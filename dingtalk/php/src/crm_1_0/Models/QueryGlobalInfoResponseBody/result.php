<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcrm_1_0\Models\QueryGlobalInfoResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var bool
     */
    public $oemEnable;

    /**
     * @var bool
     */
    public $t2t3Coexist;
    protected $_name = [
        'oemEnable' => 'oemEnable',
        't2t3Coexist' => 't2t3Coexist',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->oemEnable) {
            $res['oemEnable'] = $this->oemEnable;
        }
        if (null !== $this->t2t3Coexist) {
            $res['t2t3Coexist'] = $this->t2t3Coexist;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['oemEnable'])) {
            $model->oemEnable = $map['oemEnable'];
        }
        if (isset($map['t2t3Coexist'])) {
            $model->t2t3Coexist = $map['t2t3Coexist'];
        }

        return $model;
    }
}

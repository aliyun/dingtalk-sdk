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
    protected $_name = [
        'oemEnable' => 'oemEnable',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->oemEnable) {
            $res['oemEnable'] = $this->oemEnable;
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

        return $model;
    }
}

<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDesignByCodeResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\GetProcessDesignByCodeResponseBody\flowConfig\sidInstDetail;
use AlibabaCloud\Tea\Model;

class flowConfig extends Model
{
    /**
     * @var sidInstDetail[]
     */
    public $sidInstDetail;
    protected $_name = [
        'sidInstDetail' => 'sid_instDetail',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->sidInstDetail) {
            $res['sid_instDetail'] = [];
            if (null !== $this->sidInstDetail && \is_array($this->sidInstDetail)) {
                $n = 0;
                foreach ($this->sidInstDetail as $item) {
                    $res['sid_instDetail'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return flowConfig
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['sid_instDetail'])) {
            if (!empty($map['sid_instDetail'])) {
                $model->sidInstDetail = [];
                $n = 0;
                foreach ($map['sid_instDetail'] as $item) {
                    $model->sidInstDetail[$n++] = null !== $item ? sidInstDetail::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}

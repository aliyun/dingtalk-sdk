<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_global_e_c_1_0\Models;

use AlibabaCloud\Tea\Model;

class TiktokWebhookProcessRequest extends Model
{
    /**
     * @var string
     */
    public $tiktokContentJsonString;
    protected $_name = [
        'tiktokContentJsonString' => 'tiktokContentJsonString',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->tiktokContentJsonString) {
            $res['tiktokContentJsonString'] = $this->tiktokContentJsonString;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return TiktokWebhookProcessRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['tiktokContentJsonString'])) {
            $model->tiktokContentJsonString = $map['tiktokContentJsonString'];
        }

        return $model;
    }
}

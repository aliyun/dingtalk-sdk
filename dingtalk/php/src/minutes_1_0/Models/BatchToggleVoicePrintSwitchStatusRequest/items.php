<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vminutes_1_0\Models\BatchToggleVoicePrintSwitchStatusRequest;

use AlibabaCloud\Tea\Model;

class items extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var bool
     */
    public $open;

    /**
     * @var bool
     */
    public $shouldClearVoicePrint;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $unionId;
    protected $_name = [
        'open' => 'open',
        'shouldClearVoicePrint' => 'shouldClearVoicePrint',
        'unionId' => 'unionId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->open) {
            $res['open'] = $this->open;
        }
        if (null !== $this->shouldClearVoicePrint) {
            $res['shouldClearVoicePrint'] = $this->shouldClearVoicePrint;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return items
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['open'])) {
            $model->open = $map['open'];
        }
        if (isset($map['shouldClearVoicePrint'])) {
            $model->shouldClearVoicePrint = $map['shouldClearVoicePrint'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }

        return $model;
    }
}

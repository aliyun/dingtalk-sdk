<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class CreateTimerCardResponseBody extends Model
{
    /**
     * @var bool
     */
    public $result;

    /**
     * @var bool
     */
    public $sucess;
    protected $_name = [
        'result' => 'result',
        'sucess' => 'sucess',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->result) {
            $res['result'] = $this->result;
        }
        if (null !== $this->sucess) {
            $res['sucess'] = $this->sucess;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return CreateTimerCardResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['result'])) {
            $model->result = $map['result'];
        }
        if (isset($map['sucess'])) {
            $model->sucess = $map['sucess'];
        }

        return $model;
    }
}

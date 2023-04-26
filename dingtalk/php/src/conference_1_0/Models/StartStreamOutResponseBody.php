<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class StartStreamOutResponseBody extends Model
{
    /**
     * @var mixed[]
     */
    public $failStreamMap;

    /**
     * @var mixed[]
     */
    public $successStreamMap;
    protected $_name = [
        'failStreamMap'    => 'failStreamMap',
        'successStreamMap' => 'successStreamMap',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->failStreamMap) {
            $res['failStreamMap'] = $this->failStreamMap;
        }
        if (null !== $this->successStreamMap) {
            $res['successStreamMap'] = $this->successStreamMap;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return StartStreamOutResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['failStreamMap'])) {
            $model->failStreamMap = $map['failStreamMap'];
        }
        if (isset($map['successStreamMap'])) {
            $model->successStreamMap = $map['successStreamMap'];
        }

        return $model;
    }
}

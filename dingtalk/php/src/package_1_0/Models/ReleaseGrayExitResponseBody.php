<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vpackage_1_0\Models;

use AlibabaCloud\Tea\Model;

class ReleaseGrayExitResponseBody extends Model
{
    /**
     * @var mixed
     */
    public $reuslt;
    protected $_name = [
        'reuslt' => 'reuslt',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->reuslt) {
            $res['reuslt'] = $this->reuslt;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ReleaseGrayExitResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['reuslt'])) {
            $model->reuslt = $map['reuslt'];
        }

        return $model;
    }
}

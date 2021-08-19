<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateVideoConferenceExtInfoResponseBody extends Model
{
    /**
     * @description 失败原因
     *
     * @var string
     */
    public $case;

    /**
     * @description 返回编码
     *
     * @var string
     */
    public $code;
    protected $_name = [
        'case' => 'case',
        'code' => 'code',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->case) {
            $res['case'] = $this->case;
        }
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateVideoConferenceExtInfoResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['case'])) {
            $model->case = $map['case'];
        }
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }

        return $model;
    }
}

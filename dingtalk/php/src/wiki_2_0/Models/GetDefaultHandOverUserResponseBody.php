<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vwiki_2_0\Models;

use AlibabaCloud\Tea\Model;

class GetDefaultHandOverUserResponseBody extends Model
{
    /**
     * @example staff_id
     *
     * @var string
     */
    public $defaultHandoverUserId;
    protected $_name = [
        'defaultHandoverUserId' => 'defaultHandoverUserId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->defaultHandoverUserId) {
            $res['defaultHandoverUserId'] = $this->defaultHandoverUserId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetDefaultHandOverUserResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['defaultHandoverUserId'])) {
            $model->defaultHandoverUserId = $map['defaultHandoverUserId'];
        }

        return $model;
    }
}

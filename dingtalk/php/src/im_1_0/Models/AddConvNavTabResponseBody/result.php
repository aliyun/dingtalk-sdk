<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_1_0\Models\AddConvNavTabResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $tabId;
    protected $_name = [
        'tabId' => 'tabId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->tabId) {
            $res['tabId'] = $this->tabId;
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
        if (isset($map['tabId'])) {
            $model->tabId = $map['tabId'];
        }

        return $model;
    }
}

<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetMsgLocationResponseBody extends Model
{
    /**
     * @var string
     */
    public $msgLocationUrl;
    protected $_name = [
        'msgLocationUrl' => 'msgLocationUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->msgLocationUrl) {
            $res['msgLocationUrl'] = $this->msgLocationUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetMsgLocationResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['msgLocationUrl'])) {
            $model->msgLocationUrl = $map['msgLocationUrl'];
        }

        return $model;
    }
}

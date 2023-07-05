<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vevent_1_0\Models;

use AlibabaCloud\Tea\Model;

class RePushSuiteTicketRequest extends Model
{
    /**
     * @var int
     */
    public $suiteId;

    /**
     * @var string
     */
    public $suiteSecret;
    protected $_name = [
        'suiteId'     => 'suiteId',
        'suiteSecret' => 'suiteSecret',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->suiteId) {
            $res['suiteId'] = $this->suiteId;
        }
        if (null !== $this->suiteSecret) {
            $res['suiteSecret'] = $this->suiteSecret;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RePushSuiteTicketRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['suiteId'])) {
            $model->suiteId = $map['suiteId'];
        }
        if (isset($map['suiteSecret'])) {
            $model->suiteSecret = $map['suiteSecret'];
        }

        return $model;
    }
}

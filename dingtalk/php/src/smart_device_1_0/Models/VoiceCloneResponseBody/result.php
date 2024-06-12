<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vsmart_device_1_0\Models\VoiceCloneResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example https://xxxx
     *
     * @var string
     */
    public $mediaUrl;

    /**
     * @var string
     */
    public $requestId;
    protected $_name = [
        'mediaUrl'  => 'mediaUrl',
        'requestId' => 'requestId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->mediaUrl) {
            $res['mediaUrl'] = $this->mediaUrl;
        }
        if (null !== $this->requestId) {
            $res['requestId'] = $this->requestId;
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
        if (isset($map['mediaUrl'])) {
            $model->mediaUrl = $map['mediaUrl'];
        }
        if (isset($map['requestId'])) {
            $model->requestId = $map['requestId'];
        }

        return $model;
    }
}

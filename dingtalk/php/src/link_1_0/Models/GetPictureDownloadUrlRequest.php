<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlink_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetPictureDownloadUrlRequest extends Model
{
    /**
     * @var string
     */
    public $downloadCode;

    /**
     * @var string
     */
    public $sessionId;
    protected $_name = [
        'downloadCode' => 'downloadCode',
        'sessionId'    => 'sessionId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->downloadCode) {
            $res['downloadCode'] = $this->downloadCode;
        }
        if (null !== $this->sessionId) {
            $res['sessionId'] = $this->sessionId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetPictureDownloadUrlRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['downloadCode'])) {
            $model->downloadCode = $map['downloadCode'];
        }
        if (isset($map['sessionId'])) {
            $model->sessionId = $map['sessionId'];
        }

        return $model;
    }
}

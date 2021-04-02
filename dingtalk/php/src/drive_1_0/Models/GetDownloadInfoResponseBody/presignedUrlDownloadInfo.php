<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetDownloadInfoResponseBody;

use AlibabaCloud\Tea\Model;

class presignedUrlDownloadInfo extends Model
{
    /**
     * @description 加签url
     *
     * @var string
     */
    public $resourceUrl;

    /**
     * @description 加签url过期时间(分钟)
     *
     * @var int
     */
    public $expiration;
    protected $_name = [
        'resourceUrl' => 'resourceUrl',
        'expiration'  => 'expiration',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->resourceUrl) {
            $res['resourceUrl'] = $this->resourceUrl;
        }
        if (null !== $this->expiration) {
            $res['expiration'] = $this->expiration;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return presignedUrlDownloadInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['resourceUrl'])) {
            $model->resourceUrl = $map['resourceUrl'];
        }
        if (isset($map['expiration'])) {
            $model->expiration = $map['expiration'];
        }

        return $model;
    }
}

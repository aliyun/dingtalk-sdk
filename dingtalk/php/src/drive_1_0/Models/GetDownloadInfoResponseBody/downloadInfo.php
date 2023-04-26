<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetDownloadInfoResponseBody;

use AlibabaCloud\Tea\Model;

class downloadInfo extends Model
{
    /**
     * @var int
     */
    public $expirationSeconds;

    /**
     * @var mixed[]
     */
    public $headers;

    /**
     * @var string
     */
    public $internalResourceUrl;

    /**
     * @var string
     */
    public $resourceUrl;
    protected $_name = [
        'expirationSeconds'   => 'expirationSeconds',
        'headers'             => 'headers',
        'internalResourceUrl' => 'internalResourceUrl',
        'resourceUrl'         => 'resourceUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->expirationSeconds) {
            $res['expirationSeconds'] = $this->expirationSeconds;
        }
        if (null !== $this->headers) {
            $res['headers'] = $this->headers;
        }
        if (null !== $this->internalResourceUrl) {
            $res['internalResourceUrl'] = $this->internalResourceUrl;
        }
        if (null !== $this->resourceUrl) {
            $res['resourceUrl'] = $this->resourceUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return downloadInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['expirationSeconds'])) {
            $model->expirationSeconds = $map['expirationSeconds'];
        }
        if (isset($map['headers'])) {
            $model->headers = $map['headers'];
        }
        if (isset($map['internalResourceUrl'])) {
            $model->internalResourceUrl = $map['internalResourceUrl'];
        }
        if (isset($map['resourceUrl'])) {
            $model->resourceUrl = $map['resourceUrl'];
        }

        return $model;
    }
}

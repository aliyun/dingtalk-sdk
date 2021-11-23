<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdrive_1_0\Models\GetUploadInfoResponseBody;

use AlibabaCloud\Tea\Model;

class headerSignatureUploadInfo extends Model
{
    /**
     * @description 上传地址
     *
     * @var string
     */
    public $resourceUrl;

    /**
     * @description 过期秒数
     *
     * @var int
     */
    public $expirationSeconds;

    /**
     * @description header加签信息
     *
     * @var mixed[]
     */
    public $headers;
    protected $_name = [
        'resourceUrl'       => 'resourceUrl',
        'expirationSeconds' => 'expirationSeconds',
        'headers'           => 'headers',
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
        if (null !== $this->expirationSeconds) {
            $res['expirationSeconds'] = $this->expirationSeconds;
        }
        if (null !== $this->headers) {
            $res['headers'] = $this->headers;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return headerSignatureUploadInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['resourceUrl'])) {
            $model->resourceUrl = $map['resourceUrl'];
        }
        if (isset($map['expirationSeconds'])) {
            $model->expirationSeconds = $map['expirationSeconds'];
        }
        if (isset($map['headers'])) {
            $model->headers = $map['headers'];
        }

        return $model;
    }
}

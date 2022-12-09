<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetSpaceFileUrlResponseBody extends Model
{
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
     * @return GetSpaceFileUrlResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
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

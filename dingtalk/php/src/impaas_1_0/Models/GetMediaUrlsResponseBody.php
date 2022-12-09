<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetMediaUrlsResponseBody extends Model
{
    /**
     * @var mixed[]
     */
    public $urls;
    protected $_name = [
        'urls' => 'urls',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->urls) {
            $res['urls'] = $this->urls;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetMediaUrlsResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['urls'])) {
            $model->urls = $map['urls'];
        }

        return $model;
    }
}

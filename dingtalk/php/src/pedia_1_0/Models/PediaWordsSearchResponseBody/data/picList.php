<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vpedia_1_0\Models\PediaWordsSearchResponseBody\data;

use AlibabaCloud\Tea\Model;

class picList extends Model
{
    /**
     * @example https://1234.com
     *
     * @var string
     */
    public $mediaIdUrl;
    protected $_name = [
        'mediaIdUrl' => 'mediaIdUrl',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->mediaIdUrl) {
            $res['mediaIdUrl'] = $this->mediaIdUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return picList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['mediaIdUrl'])) {
            $model->mediaIdUrl = $map['mediaIdUrl'];
        }

        return $model;
    }
}

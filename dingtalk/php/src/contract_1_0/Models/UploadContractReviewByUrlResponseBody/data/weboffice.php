<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontract_1_0\Models\UploadContractReviewByUrlResponseBody\data;

use AlibabaCloud\Tea\Model;

class weboffice extends Model
{
    /**
     * @var string
     */
    public $url;
    protected $_name = [
        'url' => 'url',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->url) {
            $res['url'] = $this->url;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return weboffice
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['url'])) {
            $model->url = $map['url'];
        }

        return $model;
    }
}

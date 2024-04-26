<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vconference_1_0\Models\CreateCustomShortLinkResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $customShortLink;
    protected $_name = [
        'customShortLink' => 'customShortLink',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->customShortLink) {
            $res['customShortLink'] = $this->customShortLink;
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
        if (isset($map['customShortLink'])) {
            $model->customShortLink = $map['customShortLink'];
        }

        return $model;
    }
}

<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_2_0\Models\ShareUrlResponseBody;

use AlibabaCloud\Tea\Model;

class shareUrlInfo extends Model
{
    /**
     * @example http://example.com
     *
     * @var string
     */
    public $mobileUrl;

    /**
     * @example http://example.com
     *
     * @var string
     */
    public $pcUrl;
    protected $_name = [
        'mobileUrl' => 'mobileUrl',
        'pcUrl'     => 'pcUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->mobileUrl) {
            $res['mobileUrl'] = $this->mobileUrl;
        }
        if (null !== $this->pcUrl) {
            $res['pcUrl'] = $this->pcUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return shareUrlInfo
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['mobileUrl'])) {
            $model->mobileUrl = $map['mobileUrl'];
        }
        if (isset($map['pcUrl'])) {
            $model->pcUrl = $map['pcUrl'];
        }

        return $model;
    }
}

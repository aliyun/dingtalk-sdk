<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetSignNoticeUrlResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @description PC端URL
     *
     * @var string
     */
    public $pcUrl;

    /**
     * @description 移动端URL
     *
     * @var string
     */
    public $mobileUrl;
    protected $_name = [
        'pcUrl'     => 'pcUrl',
        'mobileUrl' => 'mobileUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->pcUrl) {
            $res['pcUrl'] = $this->pcUrl;
        }
        if (null !== $this->mobileUrl) {
            $res['mobileUrl'] = $this->mobileUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['pcUrl'])) {
            $model->pcUrl = $map['pcUrl'];
        }
        if (isset($map['mobileUrl'])) {
            $model->mobileUrl = $map['mobileUrl'];
        }

        return $model;
    }
}

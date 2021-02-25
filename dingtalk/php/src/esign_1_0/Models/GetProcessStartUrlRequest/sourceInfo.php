<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetProcessStartUrlRequest;

use AlibabaCloud\Tea\Model;

class sourceInfo extends Model
{
    /**
     * @var string
     */
    public $mobileUrl;

    /**
     * @var string
     */
    public $pcUrl;

    /**
     * @var string
     */
    public $showText;
    protected $_name = [
        'mobileUrl' => 'mobileUrl',
        'pcUrl'     => 'pcUrl',
        'showText'  => 'showText',
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
        if (null !== $this->showText) {
            $res['showText'] = $this->showText;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return sourceInfo
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
        if (isset($map['showText'])) {
            $model->showText = $map['showText'];
        }

        return $model;
    }
}

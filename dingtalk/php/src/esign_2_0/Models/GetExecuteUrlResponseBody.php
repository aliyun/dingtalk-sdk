<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models;

use AlibabaCloud\Tea\Model;

class GetExecuteUrlResponseBody extends Model
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
    public $longUrl;

    /**
     * @var string
     */
    public $shortUrl;
    protected $_name = [
        'mobileUrl' => 'mobileUrl',
        'pcUrl'     => 'pcUrl',
        'longUrl'   => 'longUrl',
        'shortUrl'  => 'shortUrl',
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
        if (null !== $this->longUrl) {
            $res['longUrl'] = $this->longUrl;
        }
        if (null !== $this->shortUrl) {
            $res['shortUrl'] = $this->shortUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetExecuteUrlResponseBody
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
        if (isset($map['longUrl'])) {
            $model->longUrl = $map['longUrl'];
        }
        if (isset($map['shortUrl'])) {
            $model->shortUrl = $map['shortUrl'];
        }

        return $model;
    }
}

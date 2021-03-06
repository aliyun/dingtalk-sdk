<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_2_0\Models;

use AlibabaCloud\Tea\Model;

class GetAuthUrlRequest extends Model
{
    /**
     * @var string
     */
    public $dingCorpId;

    /**
     * @var string
     */
    public $redirectUrl;
    protected $_name = [
        'dingCorpId'  => 'dingCorpId',
        'redirectUrl' => 'redirectUrl',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }
        if (null !== $this->redirectUrl) {
            $res['redirectUrl'] = $this->redirectUrl;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetAuthUrlRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }
        if (isset($map['redirectUrl'])) {
            $model->redirectUrl = $map['redirectUrl'];
        }

        return $model;
    }
}

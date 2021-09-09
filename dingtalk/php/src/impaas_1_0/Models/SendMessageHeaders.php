<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vimpaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class SendMessageHeaders extends Model
{
    public $commonHeaders;

    /**
     * @var string
     */
    public $operatingSource;

    /**
     * @var string
     */
    public $xAcsDingtalkAccessToken;
    protected $_name = [
        'operatingSource'         => 'operatingSource',
        'xAcsDingtalkAccessToken' => 'x-acs-dingtalk-access-token',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->commonHeaders) {
            $res['commonHeaders'] = $this->commonHeaders;
        }
        if (null !== $this->operatingSource) {
            $res['operatingSource'] = $this->operatingSource;
        }
        if (null !== $this->xAcsDingtalkAccessToken) {
            $res['x-acs-dingtalk-access-token'] = $this->xAcsDingtalkAccessToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SendMessageHeaders
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['commonHeaders'])) {
            $model->commonHeaders = $map['commonHeaders'];
        }
        if (isset($map['operatingSource'])) {
            $model->operatingSource = $map['operatingSource'];
        }
        if (isset($map['x-acs-dingtalk-access-token'])) {
            $model->xAcsDingtalkAccessToken = $map['x-acs-dingtalk-access-token'];
        }

        return $model;
    }
}

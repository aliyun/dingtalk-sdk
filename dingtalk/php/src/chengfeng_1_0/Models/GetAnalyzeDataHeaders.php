<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetAnalyzeDataHeaders extends Model
{
    public $commonHeaders;

    /**
     * @var string
     */
    public $xAcsDingtalkAccessToken;
    protected $_name = [
        'xAcsDingtalkAccessToken' => 'x-acs-dingtalk-access-token',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->commonHeaders) {
            $res['commonHeaders'] = $this->commonHeaders;
        }
        if (null !== $this->xAcsDingtalkAccessToken) {
            $res['x-acs-dingtalk-access-token'] = $this->xAcsDingtalkAccessToken;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetAnalyzeDataHeaders
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['commonHeaders'])) {
            $model->commonHeaders = $map['commonHeaders'];
        }
        if (isset($map['x-acs-dingtalk-access-token'])) {
            $model->xAcsDingtalkAccessToken = $map['x-acs-dingtalk-access-token'];
        }

        return $model;
    }
}

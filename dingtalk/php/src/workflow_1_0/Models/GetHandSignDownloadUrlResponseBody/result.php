<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetHandSignDownloadUrlResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example https://dingding-file-zjk.oss-cn-zhangjiakouxxxx
     *
     * @var string
     */
    public $downloadUrl;

    /**
     * @var int
     */
    public $expireIn;
    protected $_name = [
        'downloadUrl' => 'downloadUrl',
        'expireIn' => 'expireIn',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->downloadUrl) {
            $res['downloadUrl'] = $this->downloadUrl;
        }
        if (null !== $this->expireIn) {
            $res['expireIn'] = $this->expireIn;
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
        if (isset($map['downloadUrl'])) {
            $model->downloadUrl = $map['downloadUrl'];
        }
        if (isset($map['expireIn'])) {
            $model->expireIn = $map['expireIn'];
        }

        return $model;
    }
}

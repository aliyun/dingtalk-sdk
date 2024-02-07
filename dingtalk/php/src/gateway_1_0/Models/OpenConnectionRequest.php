<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vgateway_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vgateway_1_0\Models\OpenConnectionRequest\subscriptions;
use AlibabaCloud\Tea\Model;

class OpenConnectionRequest extends Model
{
    /**
     * @example suiteudabcd123
     *
     * @var string
     */
    public $clientId;

    /**
     * @example 9W1berqrwfs
     *
     * @var string
     */
    public $clientSecret;

    /**
     * @var mixed[]
     */
    public $extras;

    /**
     * @example 32.78.48.10
     *
     * @var string
     */
    public $localIp;

    /**
     * @var subscriptions[]
     */
    public $subscriptions;
    protected $_name = [
        'clientId'      => 'clientId',
        'clientSecret'  => 'clientSecret',
        'extras'        => 'extras',
        'localIp'       => 'localIp',
        'subscriptions' => 'subscriptions',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->clientId) {
            $res['clientId'] = $this->clientId;
        }
        if (null !== $this->clientSecret) {
            $res['clientSecret'] = $this->clientSecret;
        }
        if (null !== $this->extras) {
            $res['extras'] = $this->extras;
        }
        if (null !== $this->localIp) {
            $res['localIp'] = $this->localIp;
        }
        if (null !== $this->subscriptions) {
            $res['subscriptions'] = [];
            if (null !== $this->subscriptions && \is_array($this->subscriptions)) {
                $n = 0;
                foreach ($this->subscriptions as $item) {
                    $res['subscriptions'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenConnectionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['clientId'])) {
            $model->clientId = $map['clientId'];
        }
        if (isset($map['clientSecret'])) {
            $model->clientSecret = $map['clientSecret'];
        }
        if (isset($map['extras'])) {
            $model->extras = $map['extras'];
        }
        if (isset($map['localIp'])) {
            $model->localIp = $map['localIp'];
        }
        if (isset($map['subscriptions'])) {
            if (!empty($map['subscriptions'])) {
                $model->subscriptions = [];
                $n                    = 0;
                foreach ($map['subscriptions'] as $item) {
                    $model->subscriptions[$n++] = null !== $item ? subscriptions::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}

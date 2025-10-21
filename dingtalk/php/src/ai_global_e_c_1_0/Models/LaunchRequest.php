<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_global_e_c_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vai_global_e_c_1_0\Models\LaunchRequest\variants;
use AlibabaCloud\Tea\Model;

class LaunchRequest extends Model
{
    /**
     * @var string
     */
    public $description;

    /**
     * @var string[]
     */
    public $imageUrls;

    /**
     * @var string[]
     */
    public $platform;

    /**
     * @var string
     */
    public $productName;

    /**
     * @var string[]
     */
    public $sellingPoints;

    /**
     * @var string
     */
    public $sourceData;

    /**
     * @var variants[]
     */
    public $variants;

    /**
     * @var string[]
     */
    public $videoUrls;

    /**
     * @var int
     */
    public $dingAgentId;

    /**
     * @var string
     */
    public $dingClientId;

    /**
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @var int
     */
    public $dingOrgId;

    /**
     * @var string
     */
    public $dingSuiteKey;

    /**
     * @var int
     */
    public $dingTokenGrantType;

    /**
     * @var int
     */
    public $dingUid;
    protected $_name = [
        'description' => 'description',
        'imageUrls' => 'imageUrls',
        'platform' => 'platform',
        'productName' => 'productName',
        'sellingPoints' => 'sellingPoints',
        'sourceData' => 'sourceData',
        'variants' => 'variants',
        'videoUrls' => 'videoUrls',
        'dingAgentId' => 'dingAgentId',
        'dingClientId' => 'dingClientId',
        'dingIsvOrgId' => 'dingIsvOrgId',
        'dingOrgId' => 'dingOrgId',
        'dingSuiteKey' => 'dingSuiteKey',
        'dingTokenGrantType' => 'dingTokenGrantType',
        'dingUid' => 'dingUid',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->imageUrls) {
            $res['imageUrls'] = $this->imageUrls;
        }
        if (null !== $this->platform) {
            $res['platform'] = $this->platform;
        }
        if (null !== $this->productName) {
            $res['productName'] = $this->productName;
        }
        if (null !== $this->sellingPoints) {
            $res['sellingPoints'] = $this->sellingPoints;
        }
        if (null !== $this->sourceData) {
            $res['sourceData'] = $this->sourceData;
        }
        if (null !== $this->variants) {
            $res['variants'] = [];
            if (null !== $this->variants && \is_array($this->variants)) {
                $n = 0;
                foreach ($this->variants as $item) {
                    $res['variants'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->videoUrls) {
            $res['videoUrls'] = $this->videoUrls;
        }
        if (null !== $this->dingAgentId) {
            $res['dingAgentId'] = $this->dingAgentId;
        }
        if (null !== $this->dingClientId) {
            $res['dingClientId'] = $this->dingClientId;
        }
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
        }
        if (null !== $this->dingUid) {
            $res['dingUid'] = $this->dingUid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return LaunchRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['imageUrls'])) {
            if (!empty($map['imageUrls'])) {
                $model->imageUrls = $map['imageUrls'];
            }
        }
        if (isset($map['platform'])) {
            if (!empty($map['platform'])) {
                $model->platform = $map['platform'];
            }
        }
        if (isset($map['productName'])) {
            $model->productName = $map['productName'];
        }
        if (isset($map['sellingPoints'])) {
            if (!empty($map['sellingPoints'])) {
                $model->sellingPoints = $map['sellingPoints'];
            }
        }
        if (isset($map['sourceData'])) {
            $model->sourceData = $map['sourceData'];
        }
        if (isset($map['variants'])) {
            if (!empty($map['variants'])) {
                $model->variants = [];
                $n = 0;
                foreach ($map['variants'] as $item) {
                    $model->variants[$n++] = null !== $item ? variants::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['videoUrls'])) {
            if (!empty($map['videoUrls'])) {
                $model->videoUrls = $map['videoUrls'];
            }
        }
        if (isset($map['dingAgentId'])) {
            $model->dingAgentId = $map['dingAgentId'];
        }
        if (isset($map['dingClientId'])) {
            $model->dingClientId = $map['dingClientId'];
        }
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }
        if (isset($map['dingUid'])) {
            $model->dingUid = $map['dingUid'];
        }

        return $model;
    }
}

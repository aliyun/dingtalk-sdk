<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcontact_1_0\Models;

use AlibabaCloud\Tea\Model;

class TranslateFileRequest extends Model
{
    /**
     * @var int
     */
    public $dingTokenGrantType;

    /**
     * @var int
     */
    public $dingOrgId;

    /**
     * @var int
     */
    public $dingIsvOrgId;

    /**
     * @var string
     */
    public $dingSuiteKey;

    /**
     * @description 钉盘mediaId，#号开头。可以通过单步上传api获取
     *
     * @var string
     */
    public $mediaId;

    /**
     * @description 转译后文件名（含扩展名）
     *
     * @var string
     */
    public $outputFileName;

    /**
     * @description unionId
     *
     * @var string
     */
    public $unionId;

    /**
     * @var string
     */
    public $requestId;

    /**
     * @var string
     */
    public $eagleEyeTraceId;
    protected $_name = [
        'dingTokenGrantType' => 'dingTokenGrantType',
        'dingOrgId'          => 'dingOrgId',
        'dingIsvOrgId'       => 'dingIsvOrgId',
        'dingSuiteKey'       => 'dingSuiteKey',
        'mediaId'            => 'mediaId',
        'outputFileName'     => 'outputFileName',
        'unionId'            => 'unionId',
        'requestId'          => 'RequestId',
        'eagleEyeTraceId'    => 'eagleEyeTraceId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->dingTokenGrantType) {
            $res['dingTokenGrantType'] = $this->dingTokenGrantType;
        }
        if (null !== $this->dingOrgId) {
            $res['dingOrgId'] = $this->dingOrgId;
        }
        if (null !== $this->dingIsvOrgId) {
            $res['dingIsvOrgId'] = $this->dingIsvOrgId;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }
        if (null !== $this->mediaId) {
            $res['mediaId'] = $this->mediaId;
        }
        if (null !== $this->outputFileName) {
            $res['outputFileName'] = $this->outputFileName;
        }
        if (null !== $this->unionId) {
            $res['unionId'] = $this->unionId;
        }
        if (null !== $this->requestId) {
            $res['RequestId'] = $this->requestId;
        }
        if (null !== $this->eagleEyeTraceId) {
            $res['eagleEyeTraceId'] = $this->eagleEyeTraceId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return TranslateFileRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['dingTokenGrantType'])) {
            $model->dingTokenGrantType = $map['dingTokenGrantType'];
        }
        if (isset($map['dingOrgId'])) {
            $model->dingOrgId = $map['dingOrgId'];
        }
        if (isset($map['dingIsvOrgId'])) {
            $model->dingIsvOrgId = $map['dingIsvOrgId'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }
        if (isset($map['mediaId'])) {
            $model->mediaId = $map['mediaId'];
        }
        if (isset($map['outputFileName'])) {
            $model->outputFileName = $map['outputFileName'];
        }
        if (isset($map['unionId'])) {
            $model->unionId = $map['unionId'];
        }
        if (isset($map['RequestId'])) {
            $model->requestId = $map['RequestId'];
        }
        if (isset($map['eagleEyeTraceId'])) {
            $model->eagleEyeTraceId = $map['eagleEyeTraceId'];
        }

        return $model;
    }
}

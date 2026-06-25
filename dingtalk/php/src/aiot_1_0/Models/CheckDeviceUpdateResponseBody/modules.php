<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vaiot_1_0\Models\CheckDeviceUpdateResponseBody;

use AlibabaCloud\Tea\Model;

class modules extends Model
{
    /**
     * @var string
     */
    public $checksum;

    /**
     * @var string
     */
    public $checksumAlgorithm;

    /**
     * @var string
     */
    public $criticalNext;

    /**
     * @var string
     */
    public $currentVersion;

    /**
     * @var string
     */
    public $fileUrl;

    /**
     * @var string
     */
    public $latest;

    /**
     * @var string
     */
    public $moduleName;

    /**
     * @var string
     */
    public $noticeEn;

    /**
     * @var string
     */
    public $noticeZh;

    /**
     * @var string
     */
    public $upgradeMode;
    protected $_name = [
        'checksum' => 'checksum',
        'checksumAlgorithm' => 'checksumAlgorithm',
        'criticalNext' => 'criticalNext',
        'currentVersion' => 'currentVersion',
        'fileUrl' => 'fileUrl',
        'latest' => 'latest',
        'moduleName' => 'moduleName',
        'noticeEn' => 'noticeEn',
        'noticeZh' => 'noticeZh',
        'upgradeMode' => 'upgradeMode',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->checksum) {
            $res['checksum'] = $this->checksum;
        }
        if (null !== $this->checksumAlgorithm) {
            $res['checksumAlgorithm'] = $this->checksumAlgorithm;
        }
        if (null !== $this->criticalNext) {
            $res['criticalNext'] = $this->criticalNext;
        }
        if (null !== $this->currentVersion) {
            $res['currentVersion'] = $this->currentVersion;
        }
        if (null !== $this->fileUrl) {
            $res['fileUrl'] = $this->fileUrl;
        }
        if (null !== $this->latest) {
            $res['latest'] = $this->latest;
        }
        if (null !== $this->moduleName) {
            $res['moduleName'] = $this->moduleName;
        }
        if (null !== $this->noticeEn) {
            $res['noticeEn'] = $this->noticeEn;
        }
        if (null !== $this->noticeZh) {
            $res['noticeZh'] = $this->noticeZh;
        }
        if (null !== $this->upgradeMode) {
            $res['upgradeMode'] = $this->upgradeMode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return modules
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['checksum'])) {
            $model->checksum = $map['checksum'];
        }
        if (isset($map['checksumAlgorithm'])) {
            $model->checksumAlgorithm = $map['checksumAlgorithm'];
        }
        if (isset($map['criticalNext'])) {
            $model->criticalNext = $map['criticalNext'];
        }
        if (isset($map['currentVersion'])) {
            $model->currentVersion = $map['currentVersion'];
        }
        if (isset($map['fileUrl'])) {
            $model->fileUrl = $map['fileUrl'];
        }
        if (isset($map['latest'])) {
            $model->latest = $map['latest'];
        }
        if (isset($map['moduleName'])) {
            $model->moduleName = $map['moduleName'];
        }
        if (isset($map['noticeEn'])) {
            $model->noticeEn = $map['noticeEn'];
        }
        if (isset($map['noticeZh'])) {
            $model->noticeZh = $map['noticeZh'];
        }
        if (isset($map['upgradeMode'])) {
            $model->upgradeMode = $map['upgradeMode'];
        }

        return $model;
    }
}

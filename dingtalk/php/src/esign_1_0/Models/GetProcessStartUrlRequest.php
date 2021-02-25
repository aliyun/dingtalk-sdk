<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetProcessStartUrlRequest\ccs;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetProcessStartUrlRequest\files;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetProcessStartUrlRequest\participants;
use AlibabaCloud\SDK\Dingtalk\Vesign_1_0\Models\GetProcessStartUrlRequest\sourceInfo;
use AlibabaCloud\Tea\Model;

class GetProcessStartUrlRequest extends Model
{
    /**
     * @var bool
     */
    public $autoStart;

    /**
     * @var files[]
     */
    public $files;

    /**
     * @var string
     */
    public $dingCorpId;

    /**
     * @var string
     */
    public $initiatorUserId;

    /**
     * @var participants[]
     */
    public $participants;

    /**
     * @var string
     */
    public $redirectUrl;

    /**
     * @var sourceInfo
     */
    public $sourceInfo;

    /**
     * @var string
     */
    public $taskName;

    /**
     * @var ccs[]
     */
    public $ccs;

    /**
     * @var string
     */
    public $dingIsvAccessToken;

    /**
     * @var string
     */
    public $dingSuiteKey;
    protected $_name = [
        'autoStart'          => 'autoStart',
        'files'              => 'files',
        'dingCorpId'         => 'dingCorpId',
        'initiatorUserId'    => 'initiatorUserId',
        'participants'       => 'participants',
        'redirectUrl'        => 'redirectUrl',
        'sourceInfo'         => 'sourceInfo',
        'taskName'           => 'taskName',
        'ccs'                => 'ccs',
        'dingIsvAccessToken' => 'dingIsvAccessToken',
        'dingSuiteKey'       => 'dingSuiteKey',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->autoStart) {
            $res['autoStart'] = $this->autoStart;
        }
        if (null !== $this->files) {
            $res['files'] = [];
            if (null !== $this->files && \is_array($this->files)) {
                $n = 0;
                foreach ($this->files as $item) {
                    $res['files'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->dingCorpId) {
            $res['dingCorpId'] = $this->dingCorpId;
        }
        if (null !== $this->initiatorUserId) {
            $res['initiatorUserId'] = $this->initiatorUserId;
        }
        if (null !== $this->participants) {
            $res['participants'] = [];
            if (null !== $this->participants && \is_array($this->participants)) {
                $n = 0;
                foreach ($this->participants as $item) {
                    $res['participants'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->redirectUrl) {
            $res['redirectUrl'] = $this->redirectUrl;
        }
        if (null !== $this->sourceInfo) {
            $res['sourceInfo'] = null !== $this->sourceInfo ? $this->sourceInfo->toMap() : null;
        }
        if (null !== $this->taskName) {
            $res['taskName'] = $this->taskName;
        }
        if (null !== $this->ccs) {
            $res['ccs'] = [];
            if (null !== $this->ccs && \is_array($this->ccs)) {
                $n = 0;
                foreach ($this->ccs as $item) {
                    $res['ccs'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->dingIsvAccessToken) {
            $res['dingIsvAccessToken'] = $this->dingIsvAccessToken;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetProcessStartUrlRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['autoStart'])) {
            $model->autoStart = $map['autoStart'];
        }
        if (isset($map['files'])) {
            if (!empty($map['files'])) {
                $model->files = [];
                $n            = 0;
                foreach ($map['files'] as $item) {
                    $model->files[$n++] = null !== $item ? files::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['dingCorpId'])) {
            $model->dingCorpId = $map['dingCorpId'];
        }
        if (isset($map['initiatorUserId'])) {
            $model->initiatorUserId = $map['initiatorUserId'];
        }
        if (isset($map['participants'])) {
            if (!empty($map['participants'])) {
                $model->participants = [];
                $n                   = 0;
                foreach ($map['participants'] as $item) {
                    $model->participants[$n++] = null !== $item ? participants::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['redirectUrl'])) {
            $model->redirectUrl = $map['redirectUrl'];
        }
        if (isset($map['sourceInfo'])) {
            $model->sourceInfo = sourceInfo::fromMap($map['sourceInfo']);
        }
        if (isset($map['taskName'])) {
            $model->taskName = $map['taskName'];
        }
        if (isset($map['ccs'])) {
            if (!empty($map['ccs'])) {
                $model->ccs = [];
                $n          = 0;
                foreach ($map['ccs'] as $item) {
                    $model->ccs[$n++] = null !== $item ? ccs::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['dingIsvAccessToken'])) {
            $model->dingIsvAccessToken = $map['dingIsvAccessToken'];
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }

        return $model;
    }
}

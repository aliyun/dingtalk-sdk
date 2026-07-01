<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetTeamResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetTeamResponseBody\result\sceneList;
use AlibabaCloud\SDK\Dingtalk\Vdvi_1_0\Models\GetTeamResponseBody\result\tagList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $code;

    /**
     * @var string
     */
    public $dialectCode;

    /**
     * @var string
     */
    public $dialectName;

    /**
     * @var string
     */
    public $name;

    /**
     * @var sceneList[]
     */
    public $sceneList;

    /**
     * @var string
     */
    public $solutionCode;

    /**
     * @var string
     */
    public $solutionName;

    /**
     * @var tagList[]
     */
    public $tagList;
    protected $_name = [
        'code' => 'code',
        'dialectCode' => 'dialectCode',
        'dialectName' => 'dialectName',
        'name' => 'name',
        'sceneList' => 'sceneList',
        'solutionCode' => 'solutionCode',
        'solutionName' => 'solutionName',
        'tagList' => 'tagList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->dialectCode) {
            $res['dialectCode'] = $this->dialectCode;
        }
        if (null !== $this->dialectName) {
            $res['dialectName'] = $this->dialectName;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->sceneList) {
            $res['sceneList'] = [];
            if (null !== $this->sceneList && \is_array($this->sceneList)) {
                $n = 0;
                foreach ($this->sceneList as $item) {
                    $res['sceneList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->solutionCode) {
            $res['solutionCode'] = $this->solutionCode;
        }
        if (null !== $this->solutionName) {
            $res['solutionName'] = $this->solutionName;
        }
        if (null !== $this->tagList) {
            $res['tagList'] = [];
            if (null !== $this->tagList && \is_array($this->tagList)) {
                $n = 0;
                foreach ($this->tagList as $item) {
                    $res['tagList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['dialectCode'])) {
            $model->dialectCode = $map['dialectCode'];
        }
        if (isset($map['dialectName'])) {
            $model->dialectName = $map['dialectName'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['sceneList'])) {
            if (!empty($map['sceneList'])) {
                $model->sceneList = [];
                $n = 0;
                foreach ($map['sceneList'] as $item) {
                    $model->sceneList[$n++] = null !== $item ? sceneList::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['solutionCode'])) {
            $model->solutionCode = $map['solutionCode'];
        }
        if (isset($map['solutionName'])) {
            $model->solutionName = $map['solutionName'];
        }
        if (isset($map['tagList'])) {
            if (!empty($map['tagList'])) {
                $model->tagList = [];
                $n = 0;
                foreach ($map['tagList'] as $item) {
                    $model->tagList[$n++] = null !== $item ? tagList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}

<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryConvertRulesResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryConvertRulesResponseBody\result\items\sourceFiles;
use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryConvertRulesResponseBody\result\items\targetFiles;
use AlibabaCloud\Tea\Model;

class items extends Model
{
    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $description;

    /**
     * @var float
     */
    public $gmtCreate;

    /**
     * @var float
     */
    public $gmtModified;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $ruleBizId;

    /**
     * @var sourceFiles[]
     */
    public $sourceFiles;

    /**
     * @var targetFiles[]
     */
    public $targetFiles;
    protected $_name = [
        'corpId' => 'corpId',
        'description' => 'description',
        'gmtCreate' => 'gmtCreate',
        'gmtModified' => 'gmtModified',
        'name' => 'name',
        'ruleBizId' => 'ruleBizId',
        'sourceFiles' => 'sourceFiles',
        'targetFiles' => 'targetFiles',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->ruleBizId) {
            $res['ruleBizId'] = $this->ruleBizId;
        }
        if (null !== $this->sourceFiles) {
            $res['sourceFiles'] = [];
            if (null !== $this->sourceFiles && \is_array($this->sourceFiles)) {
                $n = 0;
                foreach ($this->sourceFiles as $item) {
                    $res['sourceFiles'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->targetFiles) {
            $res['targetFiles'] = [];
            if (null !== $this->targetFiles && \is_array($this->targetFiles)) {
                $n = 0;
                foreach ($this->targetFiles as $item) {
                    $res['targetFiles'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return items
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['ruleBizId'])) {
            $model->ruleBizId = $map['ruleBizId'];
        }
        if (isset($map['sourceFiles'])) {
            if (!empty($map['sourceFiles'])) {
                $model->sourceFiles = [];
                $n = 0;
                foreach ($map['sourceFiles'] as $item) {
                    $model->sourceFiles[$n++] = null !== $item ? sourceFiles::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['targetFiles'])) {
            if (!empty($map['targetFiles'])) {
                $model->targetFiles = [];
                $n = 0;
                foreach ($map['targetFiles'] as $item) {
                    $model->targetFiles[$n++] = null !== $item ? targetFiles::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
